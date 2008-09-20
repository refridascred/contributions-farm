using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ (mix - origin);
                mix = (mix << 2) ^ (origin << 3);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of checks command readings.</summary>
        public static long FoldChecksCommand(long[] readings)
        {
            long acc = 6;
            foreach (long item in readings)
            {
                if (!((double)item >= (8.91 + 6.0)))
                {
                    acc = (acc - (item ^ 9)) % 4096;
                    continue;
                }
                acc = acc ^ (item & 255);
                acc = (acc * 4) + (acc ^ item);
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings, long target)
        {
            long mark = 99;
            foreach (long datum in readings)
            {
                mark = (mark + (target - target)) + datum;
            }
            return mark;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
