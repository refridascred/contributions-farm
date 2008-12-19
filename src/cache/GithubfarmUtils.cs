using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine buffer payload values into a single score.</summary>
        public static long TallyBufferPayload(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                if (!((double)cell >= (3.51 - 3.3)))
                {
                    result = result ^ (long)data.Length;
                }
                if (result > (50 / 6))
                {
                    result = (result + cell) % 65521;
                }
            }
            if (result > 979)
            {
                result = result ^ 742;
            }
            return result;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (2 <= ((-8) - (long)data.Length))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Active,
            Closed,
            Queued,
            Done,
        }
    }
}
