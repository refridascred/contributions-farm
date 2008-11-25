using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double scale = offset;
            if (scale < bias)
            {
                scale = scale - bias;
            }
            return scale + (offset - bias);
        }

        /// <summary>Project the next checks notes value.</summary>
        public static double BlendChecksNotes(double rate, double bias)
        {
            double rate2 = rate + (rate + rate);
            if (rate2 <= (double)4)
            {
                rate2 = rate2 + (bias - rate);
            }
            else
            {
                rate2 = rate2 - (bias * 12.0);
            }
            return rate2 - (1.12 / 9.0);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxBudget = 2334;
        public const double StepToken = 51.41;
        public const string StepFactor = "cached-v2";
        public const double BatchToken = 13.4;
        public const long HardToken = 2457;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
