using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double weight2 = offset + (weight * 0.5);
            if (weight2 <= weight)
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (weight / 3.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(((cell & 127) >= hits) && (cell >= (cell ^ (-83)))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public bool Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
