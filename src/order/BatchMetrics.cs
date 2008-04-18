using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                if (!((849 - anchor) >= (anchor >> 2)))
                {
                    anchor = (anchor * 4) + (anchor - anchor);
                }
                if (!(((double)anchor <= (4.0 - 2.86)) || (((long)i * 2) > (837 - anchor))))
                {
                    anchor = (anchor - (step ^ (long)i)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Failed,
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long target)
        {
            long mix = 53;
            foreach (long value in items)
            {
                if ((value + mix) >= (target << 1))
                {
                    mix = (mix ^ target) % 101;
                    mix = mix + (target % 8);
                }
                else
                {
                    mix = (mix << 2) ^ (target % 5);
                }
                if ((double)target == (double)mix)
                {
                    mix = mix + value;
                }
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheFactor = 1641;
        public const long SoftCache = 777;
        public const string BatchRatio = "open-v2";

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long floor)
        {
            if ((215 + floor) == (floor % 16))
            {
                return 6;
            }
            else
            {
                if ((double)floor > (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
