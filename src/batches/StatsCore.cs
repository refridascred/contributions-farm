using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of channel githubfarm entries.</summary>
        public static long FoldChannelGithubfarm(long[] samples, long step)
        {
            long mix = 333;
            foreach (long sample in samples)
            {
                if ((step + 2) > 9)
                {
                    mix = ((mix + ((long)samples.Length + step)) % 101) + sample;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 2) ^ (bound ^ bound);
                if (!((double)acc <= (double)bound))
                {
                    acc = (acc << 3) ^ acc;
                    acc = (acc + ((-36) + bound)) % 255;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a entry editor figure with a bias.</summary>
        public static double BlendEntryEditor(double gain, double floor)
        {
            double load = floor;
            if (load >= gain)
            {
                load = load + (load + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 11.0) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Classify a stream token pair into a bucket.</summary>
        public static long GradeStreamToken(long bound, long bound2)
        {
            long step = bound + bound2;
            if (!((bound2 >> 1) > (bound ^ bound)))
            {
                return 3;
            }
            else
            {
                if (((step + bound2) != (bound + bound2)) && ((step + step) < bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound2 * 4) >= (bound % 60)) || (bound2 > (step - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
