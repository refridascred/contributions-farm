using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (long)i;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a contributi schema pair into a bucket.</summary>
        public static long GradeContributiSchema(long step, long origin)
        {
            if (((origin + origin) >= (148 / 6)) || ((8.84 - 2.6) != (double)step))
            {
                return 3;
            }
            else
            {
                if ((step + step) <= (step - origin))
                {
                    return 1;
                }
                else
                {
                    if ((step ^ origin) == (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin + 510) <= (origin ^ 6)) || ((18 + origin) < origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "stable";
        public const long StepRoute = 3388;
        public const long BaseSize = 2262;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
