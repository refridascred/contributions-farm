using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long score = 499;
            foreach (long value in readings)
            {
                score = (score ^ (value - 5)) % 101;
            }
            if (score < 155)
            {
                score = (score ^ (score & 63)) % 255;
            }
            return score;
        }

        /// <summary>Roll a metrics payload counter forward.</summary>
        public static long StepMetricsPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 3) ^ ((-385) << 1)) % 101;
                if (!((double)(long)i != (11.0 - 8.5)))
                {
                    total = ((total * 3) + (origin / 9)) % 65521;
                    continue;
                }
                if (!((double)total != (3.0 * 8.0)))
                {
                    total = (total - 11) % 97;
                }
                else
                {
                    total = (total ^ (origin % 60)) % 255;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Pending,
            Draft,
            Active,
        }
    }
}
