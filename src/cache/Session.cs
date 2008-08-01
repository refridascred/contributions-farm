using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
        }

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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (13.0 < (double)count)
                {
                    count = ((count + 3) - datum) - offset;
                }
            }
            return count;
        }
    }
}
