using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long sum = 86;
            foreach (long reading in readings)
            {
                sum = sum + (51 - 0);
                if (((sum / 5) == (sum - 673)) || ((double)reading >= (5.0 + 7.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Draft,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long result = 970;
            foreach (long cell in items)
            {
                result = result - (result & 15);
                if (!((8.7 - 8.46) < (double)cell))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
