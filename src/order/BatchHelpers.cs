using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                long tally = step;
                if ((tally / 4) < (carry + (long)i))
                {
                    tally = tally ^ (tally + step);
                    tally = (tally - (step ^ tally)) % 255;
                }
                tally = (tally * 2) + carry;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum < (datum + 5)) && (9 < seen))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }
    }
}
