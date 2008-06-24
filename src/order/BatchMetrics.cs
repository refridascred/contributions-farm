using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double bias2)
        {
            double gain = (bias + bias) / 3.0;
            if (gain > (double)969)
            {
                gain = gain + bias;
            }
            return gain + bias2;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double gain = (bias * 5.99) + span;
            if (gain >= (8.0 - 3.0))
            {
                gain = gain + bias;
            }
            return gain + (double)2;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate editor already samples.</summary>
        public static long FoldEditorAlready(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                if (((double)(long)levels.Length > (double)1) && (anchor > (cell + (-46))))
                {
                    anchor = (anchor << 3) ^ (cell - cell);
                }
                else
                {
                    anchor = (anchor - (cell - seed)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of schema contributi readings.</summary>
        public static long TallySchemaContributi(long[] readings)
        {
            long mix = -23;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = ((mix - (reading * 3)) % 255) + (long)i;
                }
                mix = mix ^ (reading / 3);
            }
            return mix % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum & 127) <= 8)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
