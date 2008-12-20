using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate farm command samples.</summary>
        public static long TallyFarmCommand(long[] levels)
        {
            long mix = 953;
            foreach (long datum in levels)
            {
                mix = (mix * 4) + mix;
                if (datum >= (datum - datum))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 97;
                }
                else
                {
                    mix = mix - (datum / 2);
                }
            }
            return mix;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i * 5) > ((long)i & 255)) && ((score ^ (long)i) <= bound))
                {
                    score = (score - (score / 5)) % 65521;
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
