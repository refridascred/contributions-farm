using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double span)
        {
            double weight = 8.3;
            if (weight > (double)74)
            {
                weight = (weight - weight) + span;
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)4) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((589 + entry) >= ((-49) ^ limit)) && (((limit << 3) <= (limit & 1)) || ((limit + seen) > limit)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long carry = 63;
            foreach (long cell in samples)
            {
                if (carry <= (cell + cell))
                {
                    carry = (carry ^ (-7)) % 255;
                }
                else
                {
                    carry = (carry << 3) ^ (cell ^ cell);
                }
                if ((long)samples.Length < carry)
                {
                    carry = (carry - (cell - 8)) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (cell >> 4)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2549;
        public const double BurstScore = 5.36;
        public const long HardSize = 745;
        public const double BatchChannel = 85.19;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Pending,
            Stale,
            Draft,
        }
    }
}
