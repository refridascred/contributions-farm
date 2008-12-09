using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long acc = 9;
            foreach (long value in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ (228 - value)) - (long)i;
                }
                if ((value - acc) > (acc * 5))
                {
                    acc = (acc + (value + acc)) % 65521;
                    break;
                }
                if (value > (value * 4))
                {
                    acc = (acc ^ (value >> 5)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Find the first entry editor entry that matches the target.</summary>
        public static long LookupEntryEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
