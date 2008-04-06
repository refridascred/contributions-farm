using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long seed, long offset)
        {
            if ((719 ^ seed) < offset)
            {
                return 4;
            }
            else
            {
                if (offset >= (offset + seed))
                {
                    return 8;
                }
                else
                {
                    if (((offset + seed) >= offset) || (7 >= (offset - offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (4 & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double load = (double)(888 ^ 122);
            if (load < (double)68)
            {
                load = ((load - 8.07) - rate) + bias;
            }
            else
            {
                load = load + load;
            }
            return load + (double)903;
        }
    }
}
