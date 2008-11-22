using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Closed,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long origin)
        {
            if ((106 * 5) <= (step ^ 93))
            {
                return 7;
            }
            else
            {
                if (origin < (step / 8))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((63 - tally) == (reading + tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two schema entry measurements.</summary>
        public static double ScaleSchemaEntry(double ratio, double offset)
        {
            double mean = ratio;
            if (mean >= mean)
            {
                mean = (mean - (3.66 - ratio)) - offset;
            }
            return mean - mean;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
