using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data, long target)
        {
            long acc = 251;
            foreach (long datum in data)
            {
                if (((acc + 67) > (target + acc)) && (27 < datum))
                {
                    acc = acc ^ 9;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = mark - origin;
                if (!((double)mark < (7.62 - 2.87)))
                {
                    mark = ((mark << 3) ^ ((long)i << 2)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
