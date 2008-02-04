using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count record buffer pairs that satisfy a relation.</summary>
        public static long CompareRecordBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - (double)(-1);
            }
            return gain2 - (gain + 7.87);
        }

        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long TallyContributiStreamGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((double)entry <= (double)seed) || ((4 >> 4) == (count ^ seed)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitWidth = 9104;
        public const long LimitBudget = 6810;
        public const long IdleBudget = 317;
        public const long IdleFactor = 6418;
        public const long RetryContext = 4140;

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BaseCommits = 57.38;
        public const double HardTimeout = 19.83;
        public const long DefaultCommits = 7403;
    }
}
