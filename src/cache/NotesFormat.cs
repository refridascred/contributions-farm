using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) == (65 ^ sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long step)
        {
            if ((262 + step) != (43 << 3))
            {
                return 7;
            }
            else
            {
                if (!((limit ^ 0) >= (limit / 8)))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (step / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
