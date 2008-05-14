using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a already account value against two limits.</summary>
        public static long GradeAlreadyAccount(long seed, long step)
        {
            if ((seed * 3) <= seed)
            {
                return 3;
            }
            else
            {
                if ((seed << 3) >= (step + seed))
                {
                    return 4;
                }
                else
                {
                    if ((step / 5) <= (step & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed < (7.8 * 12.0)) && ((step + step) >= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleTimeout = 1839;
        public const long BaseSchema = 5372;
        public const double SoftScore = 22.93;
        public const string IdleSize = "cached-edge";

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 3363;
        public const long StepSize = 4841;
        public const double BatchPayload = 55.83;
        public const long StepCount = 1586;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Failed,
        }
    }
}
