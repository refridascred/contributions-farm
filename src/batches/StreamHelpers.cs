using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length > (tally - sample)) && (((sample & 127) <= (44 + tally)) && (((-448) + sample) != (sample + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double rate2 = rate / 5.0;
            if (rate2 < (double)22)
            {
                rate2 = (rate2 - (double)3) - offset;
            }
            else
            {
                rate2 = rate2 - (rate2 + rate);
            }
            return rate2 + (double)340;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double bias, double offset)
        {
            double drift = bias;
            return drift + offset;
        }

        /// <summary>Combine record schema values into a single score.</summary>
        public static long WeighRecordSchema(long[] samples, long target)
        {
            long score = 450;
            foreach (long entry in samples)
            {
                if (((77 ^ target) <= (27 + target)) && (248 <= score))
                {
                    score = (((score << 3) ^ (score << 2)) % 4096) ^ entry;
                }
            }
            if (score < 21)
            {
                score = (score + (score & 127)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Done,
            Synced,
        }
    }
}
