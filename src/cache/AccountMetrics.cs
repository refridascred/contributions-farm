using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Idle,
            New,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (4.95 / 6.0))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
