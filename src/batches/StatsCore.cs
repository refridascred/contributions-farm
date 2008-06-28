using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long FoldContributiSchema(long[] levels, long step)
        {
            long total = 870;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = total ^ ((long)i + step);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total + (total % 7)) + (long)i2;
                    total = (total + (total ^ 8)) % 255;
                }
                if (!((double)reading <= 2.87))
                {
                    total = total ^ reading;
                }
            }
            if (total < 8)
            {
                total = (total ^ (34 >> 2)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Adjust a tools order reading.</summary>
        public static double ScaleToolsOrder(double weight, double bias)
        {
            double load = bias;
            if (load <= (0.8 * 1.3))
            {
                load = (load + bias) + weight;
            }
            return load + (7.7 * 15.0);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)seen > (double)1) || ((2.46 / 9.0) <= (double)seen))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long total = 65;
            foreach (long sample in levels)
            {
                if ((total ^ total) <= total)
                {
                    total = (total ^ (sample - total)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total * 4);
                }
            }
            if (total > 9)
            {
                total = total ^ total;
            }
            return total % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
