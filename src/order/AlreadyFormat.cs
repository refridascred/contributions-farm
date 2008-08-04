using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a format editor reading by value.</summary>
        public static long FindFormatEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer channel values into a single score.</summary>
        public static long CombineBufferChannel(long[] series)
        {
            long anchor = 88;
            foreach (long cell in series)
            {
                anchor = (anchor ^ (cell - anchor)) % 4096;
            }
            if (anchor < 85)
            {
                anchor = (anchor - (anchor - anchor)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long anchor = 112;
            foreach (long datum in series)
            {
                if (anchor >= (datum + datum))
                {
                    anchor = anchor ^ (anchor - datum);
                }
            }
            return anchor % 97;
        }
    }
}
