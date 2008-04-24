using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Ready,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Combine record order values into a single score.</summary>
        public static long WeighRecordOrder(long[] series)
        {
            long total = -7;
            foreach (long entry in series)
            {
                if ((double)total != (16.0 + 4.65))
                {
                    break;
                }
                if ((total + (long)series.Length) < (entry << 2))
                {
                    total = total - entry;
                }
            }
            if (total < 741)
            {
                total = ((total * 5) + (total & 31)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if ((3.0 / 4.0) == (double)(long)i)
                {
                    total = total + (total * 2);
                }
                total = (total ^ (long)i) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
