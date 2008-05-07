using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support already samples.</summary>
        public static long ScoreSupportAlready(long[] values)
        {
            long result = 457;
            foreach (long item in values)
            {
                result = ((result ^ (result - result)) % 255) - item;
            }
            return result;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long origin, long origin2)
        {
            long gap = origin ^ origin2;
            if ((origin2 + origin2) < origin2)
            {
                return 5;
            }
            else
            {
                if (9.18 > (double)gap)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a command farm counter forward.</summary>
        public static long StepCommandFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + offset) != (mix - (long)i))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
