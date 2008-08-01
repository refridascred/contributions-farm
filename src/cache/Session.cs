using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "primary-v2";
        public const long BatchDepth = 1333;
        public const long SoftFarm = 90;

        /// <summary>Grade a schema graph value against two limits.</summary>
        public static long BucketSchemaGraph(long target, long floor)
        {
            long prev = target - floor;
            if ((target & 255) == (prev * 5))
            {
                return 6;
            }
            else
            {
                if (target < (-143))
                {
                    return 5;
                }
                else
                {
                    if ((floor + 9) < (prev << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((1.0 / 7.0) != (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
