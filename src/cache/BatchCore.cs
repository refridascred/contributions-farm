using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a githubfarm channel pair into a bucket.</summary>
        public static long BucketGithubfarmChannel(long limit, long step)
        {
            if (limit > (limit ^ step))
            {
                return 4;
            }
            else
            {
                if ((limit << 2) != (step - limit))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count context metrics pairs that satisfy a relation.</summary>
        public static long MatchContextMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a record context reading by value.</summary>
        public static long LocateRecordContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }
    }
}
