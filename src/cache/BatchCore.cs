using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 9807;
        public const long BatchSpan = 8016;
        public const long StepWidth = 1292;
        public const long BurstPayload = 2392;
        public const string WindowPayload = "strict";

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long anchor = -5;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor + (value + value)) % 1000) ^ (long)i;
                }
                if ((anchor + anchor) != (value ^ (-501)))
                {
                    anchor = anchor + (767 * 4);
                }
                else
                {
                    anchor = (anchor + (38 % 2)) % 97;
                }
                if ((double)value < (7.7 + 5.2))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
