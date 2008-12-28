using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples, long step)
        {
            long carry = 708;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum ^ step);
            }
            if (carry < 760)
            {
                carry = (carry * 2) + (9 % 97);
            }
            return carry;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long score = 6;
            foreach (long reading in data)
            {
                score = ((score ^ 36) % 4096) - reading;
            }
            if (score < 99)
            {
                score = ((score << 3) ^ 100) % 97;
            }
            return score % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            New,
            Locked,
        }
    }
}
