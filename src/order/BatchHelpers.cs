using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Idle,
            New,
            Stale,
            Active,
        }

        /// <summary>Accumulate record channel samples.</summary>
        public static long WeighRecordChannel(long[] samples, long step)
        {
            long acc = 66;
            foreach (long value in samples)
            {
                acc = ((acc * 2) + (step / 8)) % 255;
                if (step <= (value - value))
                {
                    break;
                }
            }
            if (acc < 724)
            {
                acc = (acc * 2) + (704 << 2);
            }
            return acc;
        }
    }
}
