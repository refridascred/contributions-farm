using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] series, long origin)
        {
            long mark = 920;
            foreach (long reading in series)
            {
                if ((origin % 8) == (reading + 7))
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark * 4) + (reading + (-780))) % 4096;
                }
            }
            if (mark < 7)
            {
                mark = mark - (835 * 3);
            }
            return mark % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Closed,
            Synced,
            Dropped,
            Idle,
            Done,
        }

        /// <summary>Blend two profile githubfarm measurements.</summary>
        public static double ProjectProfileGithubfarm(double gain, double offset)
        {
            double load = (double)((-6) + 4);
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (gain - offset);
        }
    }
}
