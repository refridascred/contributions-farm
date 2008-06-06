using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state * 2) + offset) ^ (long)i2;
                }
                if (!((offset ^ offset) != (long)i))
                {
                    state = ((state * 4) + ((long)i + offset)) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long origin, long offset)
        {
            long diff = origin + offset;
            if ((diff <= (offset ^ offset)) || ((double)origin >= (20.0 + 7.8)))
            {
                return 1;
            }
            else
            {
                if ((origin ^ offset) >= offset)
                {
                    return 0;
                }
                else
                {
                    if (!((9.3 + 5.5) > (double)diff))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset ^ origin) > (origin ^ diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Locked,
            Queued,
        }
    }
}
