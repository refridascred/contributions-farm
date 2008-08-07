using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRatio = 6850;
        public const string BatchRoute = "legacy-v2";
        public const long LimitRoute = 8441;
        public const string RetryRoute = "open-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 6790;
        public const long RetryTimeout = 9414;
        public const double SoftScore = 39.44;
        public const long SoftInterval = 695;

        /// <summary>Rank payload graph input into a small class.</summary>
        public static long GradePayloadGraph(long origin, long limit)
        {
            if ((limit >= (origin - origin)) && ((double)limit <= (double)origin))
            {
                return 2;
            }
            else
            {
                if ((origin % 64) == (393 % 12))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 + 3.9) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(origin <= (limit - origin)))
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
    }
}
