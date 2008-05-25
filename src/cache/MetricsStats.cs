using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of schema order entries.</summary>
        public static long ScoreSchemaOrder(long[] values)
        {
            long score = 2;
            foreach (long reading in values)
            {
                if ((double)score > (14.0 + 2.9))
                {
                    score = score + (score - score);
                }
                else
                {
                    score = score - (reading & 7);
                }
            }
            if (score < 8)
            {
                score = (score + (score / 2)) % 4096;
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings)
        {
            long mix = 828;
            foreach (long cell in readings)
            {
                mix = mix + (mix << 2);
                if (((cell * 4) <= (mix - cell)) || ((mix + (long)readings.Length) != (cell >> 2)))
                {
                    mix = (mix ^ 2) % 4096;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ (mix * 4);
            }
            return mix;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Queued,
            New,
            Draft,
            Stale,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
