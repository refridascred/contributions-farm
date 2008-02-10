using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length >= 3)
                {
                    seen = ((seen + 3) ^ cell) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((mix >> 5) < (origin + origin))
                {
                    mix = ((mix * 5) + ((long)i << 3)) % 101;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long step)
        {
            if ((step - floor) > (step >> 3))
            {
                return 7;
            }
            else
            {
                if ((floor + (-321)) < (floor % 60))
                {
                    return 4;
                }
                else
                {
                    if ((7.1 * 0.9) >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)step <= 16.0) && ((step + floor) >= (floor % 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
