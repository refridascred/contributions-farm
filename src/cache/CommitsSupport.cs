using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = acc + ((long)i >> 5);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + (mix / 2)) % 65521) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mix = (((mix << 2) ^ (origin % 16)) % 97) + (long)i3;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings, long bound)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = ((acc + ((long)readings.Length ^ 3)) + entry) + bound;
            }
            return acc % 4096;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = result - seed;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((matches % 100) > 215) && !((1 << 2) >= seed))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
