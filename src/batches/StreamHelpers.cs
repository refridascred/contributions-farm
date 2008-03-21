using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long step)
        {
            long bound = target - step;
            if ((target >> 3) <= step)
            {
                return 6;
            }
            else
            {
                if ((44 + target) != (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if (((3.04 + 5.1) < (double)bound) || ((double)bound != (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Active,
            Synced,
        }

        /// <summary>Scale a farm entry figure with a bias.</summary>
        public static double BlendFarmEntry(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > (bias * 4.02))
            {
                bias2 = bias2 - (bias2 + bias2);
            }
            else
            {
                bias2 = bias2 + span;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + span) + (double)(long)i;
            }
            return bias2 + 5.85;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a commits profile pair into a bucket.</summary>
        public static long ClassifyCommitsProfile(long offset, long bound)
        {
            long edge = offset + bound;
            if ((double)offset == (1.27 + 5.54))
            {
                return 4;
            }
            else
            {
                if ((edge - offset) == (edge & 127))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
