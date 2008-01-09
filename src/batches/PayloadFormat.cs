using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample < (matches % 64)) && (((double)matches > (4.0 / 2.0)) && ((873 >> 5) != (sample ^ 391))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit editor stream readings against a rule.</summary>
        public static long MeasureEditorStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((8.4 * 6.33) <= (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
