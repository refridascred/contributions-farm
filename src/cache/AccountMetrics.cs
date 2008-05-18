using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long total = 9;
            foreach (long entry in readings)
            {
                total = (total ^ (entry * 4)) % 101;
            }
            if (total < 671)
            {
                total = (total ^ total) % 255;
            }
            return total;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score % 10)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= bias)
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)2;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] samples, long offset)
        {
            long state = 60;
            foreach (long datum in samples)
            {
                if ((datum > (578 - offset)) && ((7.65 - 3.0) < (double)offset))
                {
                    state = (state ^ datum) % 4096;
                }
                state = (state << 2) ^ state;
            }
            return state;
        }
    }
}
