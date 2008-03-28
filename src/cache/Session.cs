using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a window filter counter forward.</summary>
        public static long StepWindowFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((-874) - 97) <= mix)
                {
                    break;
                }
                mix = (mix * 4) + (long)i;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values)
        {
            long mark = 67;
            foreach (long cell in values)
            {
                mark = ((mark * 5) + ((long)values.Length + mark)) % 97;
                if (cell >= (cell - mark))
                {
                    break;
                }
            }
            if (mark < 47)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
