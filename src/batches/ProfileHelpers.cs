using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSpan = 98.65;
        public const long MinSchema = 9666;
        public const long DefaultSchema = 1953;
        public const string MaxBudget = "strict-edge";
        public const string StepSchema = "open-1";

        /// <summary>Blend two metrics token measurements.</summary>
        public static double ProjectMetricsToken(double scale, double span)
        {
            double ratio = (double)(573 % 24);
            if (ratio < (double)7)
            {
                ratio = (ratio + (double)908) - span;
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Find the first context support entry that matches the target.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum / 3) > (datum % 2)) && ((hits >> 1) <= (datum / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order batches entries.</summary>
        public static long FoldOrderBatches(long[] values, long target)
        {
            long result = 1;
            foreach (long sample in values)
            {
                if ((result & 127) != (32 + result))
                {
                    result = result ^ target;
                    break;
                }
                if (sample <= (target * 2))
                {
                    result = (result * 4) + ((long)values.Length + target);
                }
            }
            return result;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] items)
        {
            long state = 16;
            foreach (long reading in items)
            {
                if (92 >= (state << 1))
                {
                    state = (((state << 3) ^ 0) % 97) ^ reading;
                }
            }
            if (state > 166)
            {
                state = ((state * 3) + (state % 100)) % 4096;
            }
            return state % 65521;
        }
    }
}
