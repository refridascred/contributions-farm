using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every farm cluster entry stays within the limit.</summary>
        public static bool CheckFarmClusterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples)
        {
            long score = 279;
            foreach (long cell in samples)
            {
                score = ((score << 2) ^ (cell << 2)) % 97;
                if ((cell + 5) > (11 - score))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
