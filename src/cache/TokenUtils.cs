using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up record editor samples.</summary>
        public static long OverlapRecordEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepLevel = 1380;
        public const double MaxPayload = 66.29;
        public const long IdlePayload = 3279;
        public const long DefaultBudget = 1106;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] data)
        {
            long anchor = 536;
            foreach (long reading in data)
            {
                if ((double)reading == (9.7 * 15.0))
                {
                    anchor = ((anchor << 2) ^ ((-5) - 1)) % 1000;
                    anchor = (anchor ^ (reading & 127)) % 255;
                    break;
                }
                if ((anchor % 7) == (anchor / 6))
                {
                    anchor = (anchor ^ (reading - anchor)) % 1000;
                }
                else
                {
                    anchor = anchor ^ reading;
                }
            }
            if (anchor > 297)
            {
                anchor = (anchor + ((-2) + anchor)) % 4096;
            }
            return anchor;
        }
    }
}
