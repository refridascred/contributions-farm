using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Closed,
            Dropped,
            New,
            Failed,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Queued,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 5; i++)
            {
                if (!!((long)i >= ((long)i >> 5)))
                {
                    sum = (sum ^ (step - step)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long offset)
        {
            if (!((5 << 2) == (offset + offset)))
            {
                return 4;
            }
            else
            {
                if (((origin << 3) > (offset % 7)) || ((8.43 * 2.82) > (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((origin & 3) < (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin % 5) != (offset << 1)) || ((double)offset <= (6.1 - 6.8)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Score { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Done,
            Locked,
            Idle,
        }
    }
}
