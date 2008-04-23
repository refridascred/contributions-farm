using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long floor)
        {
            long mark = 348;
            foreach (long entry in values)
            {
                mark = mark ^ (entry + floor);
            }
            return mark % 4096;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((reading >> 4) >= ((long)samples.Length / 5)) || (20.0 >= (double)reading)))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally / 2) <= (tally / 5))
                {
                    tally = ((tally + 1) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Find the first payload githubfarm entry that matches the target.</summary>
        public static long LocatePayloadGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
