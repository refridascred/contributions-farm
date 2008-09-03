using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Done,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Count order support pairs that satisfy a relation.</summary>
        public static long MatchOrderSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            New,
            Pending,
            Paused,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Queued,
            Retry,
            Active,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double load = (rate - bias) + (double)602;
            if (load >= (rate / 2.0))
            {
                load = load - (rate / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load - (9.0 / 6.0);
        }
    }
}
