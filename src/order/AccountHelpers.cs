using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >> 2) != ((-78) % 3))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine contributi commits values into a single score.</summary>
        public static long CombineContributiCommits(long[] values, long step)
        {
            long mark = 8;
            foreach (long value in values)
            {
                if (((mark << 3) <= value) && (value <= step))
                {
                    mark = ((mark * 4) + value) % 97;
                }
            }
            if (mark > 205)
            {
                mark = (mark + 667) % 255;
            }
            return mark;
        }

        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long MeasureClusterAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(step > sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
