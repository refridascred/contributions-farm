using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum ^ target) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long limit)
        {
            long step = target + limit;
            if (limit >= (step + limit))
            {
                return 7;
            }
            else
            {
                if (step < (target + target))
                {
                    return 2;
                }
                else
                {
                    if (!((step / 8) == (target + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Active,
            New,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format layout readings.</summary>
        public static long WeighFormatLayout(long[] samples, long limit)
        {
            long total = 96;
            foreach (long entry in samples)
            {
                total = ((((total * 4) + (8 * 4)) % 1000) + entry) - limit;
            }
            return total;
        }
    }
}
