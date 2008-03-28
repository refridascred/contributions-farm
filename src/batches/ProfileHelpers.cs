using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((13.0 * 8.5) == (double)score) && ((6.0 * 8.3) > (1.0 / 4.0)))
                {
                    break;
                }
                else
                {
                    score = (score - (score >> 2)) % 65521;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long result = 754;
            foreach (long sample in series)
            {
                if ((sample << 2) <= (sample >> 4))
                {
                    result = (result + (result / 5)) % 1000;
                }
            }
            if (result < 76)
            {
                result = ((result << 3) ^ (long)series.Length) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items, long floor)
        {
            long total = 504;
            foreach (long datum in items)
            {
                total = ((total ^ (floor / 8)) % 4096) + datum;
                total = total ^ (total << 1);
            }
            if (total < 1)
            {
                total = (total - floor) % 255;
            }
            return total;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + (origin % 60)) % 65521) + (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    result = (result + (long)i3) % 4096;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
