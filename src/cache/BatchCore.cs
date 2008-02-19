using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftFactor = 2785;
        public const long StepCommand = 2947;
        public const long MaxFactor = 6739;
        public const long BatchWidth = 2682;

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                if (7 <= ((long)i << 2))
                {
                    anchor = anchor - ((long)i + anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Project the next checks channel value.</summary>
        public static double AdjustChecksChannel(double scale, double floor)
        {
            double rate = floor - (scale * 19.0);
            return rate - rate;
        }

        /// <summary>Match up editor account samples.</summary>
        public static long PairEditorAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
