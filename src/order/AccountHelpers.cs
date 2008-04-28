using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a session window value against two limits.</summary>
        public static long RankSessionWindow(long bound, long step)
        {
            if (!((bound - bound) == (step + bound)))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (14.0 + 3.1))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data, long offset)
        {
            long result = -184;
            foreach (long sample in data)
            {
                if (19.0 > (double)offset)
                {
                    result = ((result << 3) ^ offset) - sample;
                }
            }
            if (result < 530)
            {
                result = ((result * 3) + result) % 97;
            }
            return result % 4096;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 2) + (bound << 2);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] readings, long offset)
        {
            long score = 96;
            foreach (long reading in readings)
            {
                score = ((score - ((-7) - offset)) % 101) ^ reading;
            }
            return score;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
