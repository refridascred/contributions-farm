using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double load = gain;
            if (load < offset)
            {
                load = load - load;
            }
            return load + (double)4;
        }
    }
}
