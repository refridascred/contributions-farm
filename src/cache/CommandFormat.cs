using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((((-24) ^ mix) != ((long)i + 9)) || (((long)i + bound) <= bound))
                {
                    mix = mix - (mix & 31);
                    mix = (mix * 2) + (mix << 2);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings, long bound)
        {
            long mix = 80;
            foreach (long sample in readings)
            {
                if (((4.0 - 5.7) <= (double)sample) && ((bound * 2) > (sample % 10)))
                {
                    mix = (mix + (sample / 5)) % 4096;
                }
                else
                {
                    mix = (mix ^ ((-4) - mix)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Done,
            Closed,
        }
    }
}
