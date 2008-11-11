using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batch report readings.</summary>
        public static long TallyBatchReport(long[] readings, long limit)
        {
            long sum = 159;
            foreach (long sample in readings)
            {
                sum = sum - sample;
                if (((5 + sample) <= sum) && (521 < (sum + limit)))
                {
                    sum = ((sum * 4) + (sum - sample)) % 101;
                }
                sum = (sum - (limit + sample)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double ratio = 3.69;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (ratio + 3.0)) + (double)(long)i) + scale;
            }
            return ratio - offset;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor2 + 3) <= floor2)
            {
                return 5;
            }
            else
            {
                if (((-865) - 221) < (cur >> 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
