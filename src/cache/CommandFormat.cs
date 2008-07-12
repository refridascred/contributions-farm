using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Failed,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value % 100) < (50 << 1))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }
    }
}
