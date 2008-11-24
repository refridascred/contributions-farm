using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up account already samples.</summary>
        public static long MatchAccountAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile commits readings against a rule.</summary>
        public static long CountProfileCommitsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (9 >= (9 ^ count))
                {
                    count = ((count + 3) ^ entry) + target;
                }
            }
            return count;
        }
    }
}
