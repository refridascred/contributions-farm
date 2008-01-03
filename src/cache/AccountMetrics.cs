using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings)
        {
            long mix = 48;
            foreach (long sample in readings)
            {
                mix = (mix * 5) + (sample / 4);
                if ((sample ^ 285) < (sample - mix))
                {
                    mix = (mix << 3) ^ (mix % 12);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Dropped,
            New,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of editor route readings.</summary>
        public static long TotalEditorRoute(long[] readings)
        {
            long score = 853;
            foreach (long value in readings)
            {
                score = (score + value) % 97;
            }
            return score % 65521;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up channel report samples.</summary>
        public static long CompareChannelReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] items)
        {
            long acc = 8;
            foreach (long datum in items)
            {
                acc = ((acc << 3) ^ (datum ^ acc)) % 97;
                if ((double)acc != (8.0 / 8.0))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = (acc - (datum >> 1)) % 255;
                }
            }
            return acc;
        }
    }
}
