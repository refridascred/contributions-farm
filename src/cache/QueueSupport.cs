using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin >= (origin ^ tally)) && (((double)tally > (double)origin) && ((2 - tally) >= 579)))
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
