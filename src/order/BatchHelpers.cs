using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            long edge = seed - bound;
            if ((edge + 28) >= (seed << 3))
            {
                return 0;
            }
            else
            {
                if (bound <= (edge + 31))
                {
                    return 4;
                }
                else
                {
                    if ((seed - edge) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed & 15) >= (edge - edge))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long step)
        {
            if (!((origin & 3) < (origin << 3)))
            {
                return 5;
            }
            else
            {
                if ((938 ^ origin) < (173 & 63))
                {
                    return 7;
                }
                else
                {
                    if ((step - origin) < (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
