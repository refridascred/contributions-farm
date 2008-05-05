using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell & 31) < cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            long step = seed ^ offset;
            if (((offset ^ offset) <= 952) || ((step + offset) != (step / 9)))
            {
                return 4;
            }
            else
            {
                if (!((offset & 15) != (seed >> 3)))
                {
                    return 3;
                }
                else
                {
                    if (((699 & 7) < (step + offset)) && (offset > (117 ^ (-4))))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6 / 2) == (step - step))
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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
