using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen + 445) > 4)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload graph series from a seed.</summary>
        public static long RollPayloadGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((6 % 97) != (limit - limit))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] series)
        {
            long mix = 553;
            foreach (long value in series)
            {
                mix = (mix ^ value) % 65521;
            }
            if (mix < 72)
            {
                mix = (mix + 17) % 65521;
            }
            return mix % 65521;
        }
    }
}
