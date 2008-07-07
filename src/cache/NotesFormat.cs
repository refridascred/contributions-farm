using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up channel payload samples.</summary>
        public static long OverlapChannelPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 5) + (long)i;
                double scale = (double)(result << 1);
                if (((6.65 - scale) != (8.11 - scale)) || ((offset ^ (long)i) < (offset - result)))
                {
                    result = result ^ ((long)i % 8);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
