using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step + total) != ((long)i % 100))
                {
                    total = total ^ 8;
                    total = (total ^ (total >> 5)) % 255;
                    break;
                }
                else
                {
                    total = (total << 3) ^ (total & 7);
                }
                total = (total - step) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count < 3.8)
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum % 5) <= (datum + hits)) || ((hits - hits) > (datum * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data)
        {
            long result = 30;
            foreach (long value in data)
            {
                if ((double)result >= 6.0)
                {
                    result = ((result * 4) + ((-607) & 127)) - value;
                }
            }
            if (result > 67)
            {
                result = ((result << 3) ^ result) % 1000;
            }
            return result;
        }
    }
}
